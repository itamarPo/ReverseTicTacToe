namespace Ex05_UserInterface
{
    using System;

    public class ButtonLocationEventArgs : EventArgs
    {
        public int RowIndex { get; }
        public int ColumnIndex { get; }

        public ButtonLocationEventArgs(int rowIndex, int columnIndex)
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
        }
    }
}
