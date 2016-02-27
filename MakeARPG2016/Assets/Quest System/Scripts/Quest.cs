//using a namespace to ogranize all of our quest information
namespace QuestSystem
{
    //basic quest class object
    public class Quest
    {

        //Name
        //DescriptionSummary
        //Quest Hint
        //Quest Dialog
        //sourceID
        //questID
        //chain quest and the next quest is blank
        //chainquestiD
        private IQuestInformation information;
        public IQuestInformation Information
        {
            get { return information; }
        }


        //objectives
        //bonus objectives
        //rewards
        //events
            //on completetion
            //on failed
            //on update

    }
}

