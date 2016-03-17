namespace QuestSystem
{

    public class QuestText : IQuestText
    {
        private string title;
        private string descriptionSummary;
        private string dialog;
        private string hint;

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

        public string Title
        {
            get
            {
                return title;
            }
        }

   



    }



}
