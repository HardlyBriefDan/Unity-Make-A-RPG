using System.Collections.Generic;

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
        public Quest()
        {
          
        }


        //objectives
        private List<IQuestObjective> objectives;
        //Collection Objective
            //10 feathers
            //killing 4 enemies
        //Location Objective
            //go from point A to B
            //Timed you have 10 mins to get to point B from A

        //bonus objectives
        //rewards


        //events
            //on completetion
            //on failed
            //on update

        private bool IsComplete()
        {
            for (int i = 0; i < objectives.Count; i++)
            {
                if (objectives[i].IsComplete != false && objectives[i].IsBonus == false)
                {
                    return false;
                } 
            }
            return true;    //get reward!! fire on complete event!
        }

    }
}

