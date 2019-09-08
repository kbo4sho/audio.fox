internal interface IStage
{
    bool CanAdvance { get; }
    Translateable[] Childs { get; }
}