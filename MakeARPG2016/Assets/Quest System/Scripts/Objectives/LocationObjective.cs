
using System;

namespace QuestSystem
{
    public class LocationObjective : IQuestObjective
    {
        private string title;
        private string description;
        private bool isComplete;
        private bool isBonus;
        private Location targetLocation;    //zone, 2d cord, 3d cord


        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public bool IsComplete
        {
            get
            {
                return isComplete;
            }
        }

        public bool IsBonus
        {
            get
            {
                return isBonus;
            }
        }

        public void CheckProgress()
        {
            //if players location is equal to our target location then we are complete and we have finished objective
            if (Player.GetLocation.Compare(targetLocation))
                isComplete = true;
            else
                isComplete = false;
        }

        public void UpdateProgress()
        {
            throw new NotImplementedException();
        }
    }
}
