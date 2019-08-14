internal interface IStage
{
    bool CanAdvance { get; }
    HookPointGeneratorChild[] Childs { get; }
}