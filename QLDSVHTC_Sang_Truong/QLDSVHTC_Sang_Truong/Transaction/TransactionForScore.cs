using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSVHTC_Sang_Truong
{
    abstract class TransactionForScore
    {
        public abstract void execute();
        public abstract void undo();
        public abstract void redo();
        public int position; 
        public BindingSource binding;

        
        public bool changePositionWhenUndo = false;
        public bool changePossionWhenExec = false; 
    }

    class CommandManagerForScore
    {

        private Stack<Transaction> undoStack;
        private Stack<Transaction> redoStack;
        int markPositionForChange = -1;
        public CommandManagerForScore()
        {
            undoStack = new Stack<Transaction>();
            redoStack = new Stack<Transaction>();

        }

        public Transaction getLastUndoNode()
        {
            return undoStack.Peek();
        }

        public int undoStackSize()
        {
            return undoStack.Count;
        }

        public int redoStackSize()
        {
            return redoStack.Count;
        }

        public void initAction(Transaction action)
        {
            action.redo();
            undoStack.Push(action);
        }
        public void execute(Transaction action)
        {
            int originPosition = action.position;
            action.execute();
            undoStack.Push(action);
            if (action.changePossionWhenExec == true)//dành cho trường hợp delete.
            {
                this.changeMarkPostion(originPosition); 

                this.updatePosition(originPosition);
            }
            
            
           
        }

        public void commit(Transaction action)
        {
            action.execute();
        }

        public void undo()
        {

            Transaction action = undoStack.Pop();
            redoStack.Push(action);

            int firstPosition = action.position;
            //MessageBox.Show("vi tri dau: " + firstPosition);
            action.undo();
            //nếu là delete: 
            if (firstPosition < 0)
            {
                this.updatePosition(firstPosition, action.position);

                //MessageBox.Show("vi tri dau: " + firstPosition + "vi tri sau: " + action.position);
            }
            if (action.changePositionWhenUndo)
            {
                this.changeMarkPostion(firstPosition); 
                this.updatePosition(firstPosition); 
            }
            

        }

        public void redo()
        {
            Transaction action = redoStack.Pop();
            undoStack.Push(action);

            int firstPosition = action.position;
            //MessageBox.Show("vi tri dau: " + firstPosition);
            action.redo();
            //dành cho insert: 
            if (firstPosition < 0)
            {
                this.updatePosition(firstPosition, action.position); 
            }

            //dành cho delete: 
            if (action.changePossionWhenExec == true)//dành cho trường hợp delete.
            {
                this.changeMarkPostion(firstPosition);
                this.updatePosition(firstPosition);
            }


        }
        public void clear()
        {
            undoStack.Clear();
            redoStack.Clear();
        }


        // khi user chon update/insert nhung cancel ma k commit
        public void clearLastNode()
        {
            undoStack.Pop();

        }
        public void updatePosition(int positionMark)
        {
          
            foreach (Transaction item in redoStack)
            {
                if (item.position > positionMark)
                    item.position -= 1; 

            }
            foreach (Transaction item in undoStack)
            {
                if (item.position > positionMark)
                    item.position -= 1;
            }
        }
        public void updatePosition(int first, int later)
        {
            foreach (Transaction item in redoStack)
            {
                if (item.position == first)
                    item.position = later;

            }
            foreach (Transaction item in undoStack)
            {
                if (item.position == first)
                    item.position = later;
            }
        }
        public void changeMarkPostion(int positionMark)
        {
            foreach (Transaction item in redoStack)
            {
                if (item.position == positionMark)
                    item.position = this.markPositionForChange;

            }
            foreach (Transaction item in undoStack)
            {
                if (item.position == positionMark)
                    item.position = this.markPositionForChange;
            }
            this.markPositionForChange--; 
        }
    }

    
    class UpdateActionForScore : Transaction
    {
       
        Object[] oldData;
    
        public UpdateActionForScore(BindingSource binding)
        {
            this.binding = binding;
        }
       

        
        public void getData()
        {
            binding.EndEdit();
            binding.ResetCurrentItem(); 
            
        }

       

        public override void execute()
        {
            position = binding.Position;
            // save lai data
            oldData = ((DataRowView)binding.Current).Row.ItemArray;
           // MessageBox.Show("Execute: "+ oldData[0] + "-" + oldData[1] + "-" + oldData[2] + "-" + oldData[3] + "-" + oldData[4] + "-" + oldData[5] + "-" + oldData[6]);
        }

        public override void undo()
        {
            // update lai data
            DataRowView row = (DataRowView)binding[position];

            for (int i = 3; i <= 5; i++)
            {
                try { row[i] = oldData[i]; } catch (Exception ex) { }

            }
            binding.EndEdit();
            binding.ResetCurrentItem();
            //MessageBox.Show("redo: " + position + oldData[0] + "-" + oldData[1] + "-" + oldData[2] + "-" + oldData[3] + "-" + oldData[4] + "-" + oldData[5] + "-" + oldData[6]);
        }

        public override void redo()
        {
            try
            {



                DataRowView row = (DataRowView)binding[position];
                for (int i = 3; i <= 5; i++)
                {

                    row[i] = oldData[i];
                }
                binding.EndEdit();
                binding.ResetCurrentItem();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi chỗ này nè: "+ex.Message); 
            }

        }
    }



}
