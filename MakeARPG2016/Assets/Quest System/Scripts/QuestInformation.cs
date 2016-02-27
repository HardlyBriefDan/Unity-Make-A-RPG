
using System;

namespace QuestSystem
{

    public class QuestInformation : IQuestInformation
    {
        private string name;
        private string descriptionSummary;
        private string dialog;
        private string hint;
        private int questID;
        private int chainQuestID;
        private int sourceID;


        public int ChainQuestID
        {
            get
            {
                return chainQuestID;
            }
        }

        public string DescriptionSummary
        {
            get
            {
                return descriptionSummary;
            }
        }

        public string Dialog
        {
            get
            {
                return dialog;
            }
        }

        public string Hint
        {
            get
            {
                return hint;
            }
        }

        public string Name
        {
            get
            {
                return descriptionSummary;
            }
        }

        public int QuestID
        {
            get
            {
                return questID;
            }
        }

        public int SourceID
        {
            get
            {
                return sourceID;
            }
        }
    }
}
