namespace QuestSystem
{
    public interface IQuestInformation
    {
        string Name { get; }
        string DescriptionSummary { get; }
        string Hint { get; }
        string Dialog { get; }
        int SourceID { get; }
        int ChainQuestID { get; }
        int QuestID { get; }
    }
}

