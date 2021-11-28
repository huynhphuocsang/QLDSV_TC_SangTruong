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
        public int position =0;
        public BindingSource binding;

    }
    class CommandManagerForScore
    {

        private Stack<TransactionForScore> undoStack;
        private Stack<TransactionForScore> redoStack;
        public CommandManagerForScore()
        {
            undoStack = new Stack<TransactionForScore>();
            redoStack = new Stack<TransactionForScore>();

        }

        public TransactionForScore getLastUndoNode()
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

        public void initAction(TransactionForScore action)
        {
            action.redo();
            undoStack.Push(action);
        }
        public void execute(TransactionForScore action)
        {
            int originPosition = action.position;
            action.execute();
            undoStack.Push(action);
        }

        public void commit(TransactionForScore action)
        {
            action.execute();
        }

        public void undo()
        {

            TransactionForScore action = undoStack.Pop();
            redoStack.Push(action);

            int firstPosition = action.position;
            //MessageBox.Show("vi tri dau: " + firstPosition);
            action.undo();
           
            


        }

        public void redo()
        {
            TransactionForScore action = redoStack.Pop();
            undoStack.Push(action);
            //MessageBox.Show("vi tri dau: " + firstPosition);
            action.redo();
            
        }
        public void clear()
        {
            undoStack.Clear();
            redoStack.Clear();
        }


       
        public void clearLastNode()
        {
            undoStack.Pop();

        }
       
    }

    class UpdateActionForScore : TransactionForScore
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
            try
            {
                binding.EndEdit();
                binding.ResetCurrentItem();
                //MessageBox.Show("redo: " + position + oldData[0] + "-" + oldData[1] + "-" + oldData[2] + "-" + oldData[3] + "-" + oldData[4] + "-" + oldData[5] + "-" + oldData[6]);
            }catch(Exception e)
            {
                
            }


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
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi chỗ này nè: " + ex.Message);
            }

        }
    }
}