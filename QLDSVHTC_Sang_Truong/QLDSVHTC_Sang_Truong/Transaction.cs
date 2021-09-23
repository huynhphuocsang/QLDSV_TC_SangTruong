using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSVHTC_Sang_Truong
{
    interface Transaction
    {
        void execute();
        void undo();
        void redo();
    }

    class CommandManager
    {

        private Stack<Transaction> undoStack;
        private Stack<Transaction> redoStack;
        public CommandManager()
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
            action.execute();
            undoStack.Push(action);

        }

        public void commit(Transaction action)
        {
            action.execute();
        }

        public void undo()
        {

            Transaction action = undoStack.Pop();
            action.undo();
            redoStack.Push(action);

        }

        public void redo()
        {
            Transaction action = redoStack.Pop();
            action.redo();
            undoStack.Push(action);
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
    }

    class DeleteAction : Transaction
    {
        BindingSource binding;

        Object[] data;

        public DeleteAction(BindingSource binding)
        {
            this.binding = binding;

        }

        public void execute()
        {
            // save lai data
            data = ((DataRowView)binding.Current).Row.ItemArray;
            // thuc thi delet
            binding.RemoveCurrent(); // delete

        }

        public void redo()
        {
            // save lai data
            data = ((DataRowView)binding.Current).Row.ItemArray;
            // thuc thi delet
            binding.RemoveCurrent(); // delete
        }

        public void undo()
        {
            // insert lai data
            binding.AddNew();
            DataRowView row = (DataRowView)binding.Current;
            for (int i = 0; i < data.Length; i++)
            {
                row[i] = data[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
        }
    }

    // edit lai class se chay sau khi user nhap data, de co dc data redo
    class InsertAction : Transaction
    {
        BindingSource binding;
        int position;
        Object[] data;
        public InsertAction(BindingSource binding)
        {
            this.binding = binding;

        }

        // chay insert voi data user nhap, chay sau getdata()
        public void execute()
        {
            binding.AddNew(); // tao dong trong va nhay xuong cho edit
            // save lai vi tri
            position = binding.Position;
        }

        // chay khi user bam nut chuan bi insert
        public void redo()
        {
            try
            {
                binding.AddNew(); // tao dong trong va nhay xuong cho edit
                                  // save lai vi tri

                position = binding.Position;
                // update lai data
                DataRowView row = (DataRowView)binding[binding.Position];
                for (int i = 0; i < data.Length; i++)
                {
                    row[i] = data[i];
                }
                binding.EndEdit();
                binding.ResetCurrentItem();

            }
            catch
            {
                return;

            }

        }
        // can goi de luu data cho redo
        public void getData()
        {
            data = ((DataRowView)binding.Current).Row.ItemArray;
        }

        public void undo()
        {
            // delete record dc insert tai vi tri da save
            binding.RemoveAt(position);
        }
    }

    // tuong tu insert action: luu data truoc de undo, data sau de redo
    class UpdateAction : Transaction
    {
        BindingSource binding;
        Object[] oldData;
        Object[] newData;
        int position;
        public UpdateAction(BindingSource binding)
        {
            this.binding = binding;
        }
        // giai doan 2
        public void execute()
        {
            // save lai data
            oldData = ((DataRowView)binding.Current).Row.ItemArray;
            position = binding.Position;

        }
        // khoi tao bat dau nhap lieu, giai doan 1
        public void redo()
        {
            // update lai data
            try
            {
                DataRowView row = (DataRowView)binding[position];
                for (int i = 0; i < oldData.Length; i++)
                {
                    row[i] = newData[i];
                }
                binding.EndEdit();
                binding.ResetCurrentItem();
            }
            catch
            {
                return;
            }

        }

        // can goi de luu data cho redo
        public void getData()
        {
            binding.EndEdit();
            binding.ResetCurrentItem(); // danh dau 2 dong
            newData = ((DataRowView)binding.Current).Row.ItemArray;
        }

        public void undo()
        {
            // update lai data
            DataRowView row = (DataRowView)binding[position];

            for (int i = 0; i < oldData.Length; i++)
            {
                try { row[i] = oldData[i]; } catch (Exception ex) { }

            }
            binding.EndEdit();
            binding.ResetCurrentItem();
        }
    }



}
