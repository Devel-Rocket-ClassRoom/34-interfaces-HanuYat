interface IUndoable
{
    void Undo();
}

interface IRedoable : IUndoable
{
    void Redo();
}