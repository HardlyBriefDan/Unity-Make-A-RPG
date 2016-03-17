using UnityEngine;
using System.Collections;
using System;

namespace QuestSystem
{
    public class CollectionObjective : IQuestObjective
    {
        private string title;
        private string description;
        private int collectionAmount;   //total amount of whatever we need
        private int currentAmount; //starts at 0
        private GameObject itemToCollect;

        //collect 10 feathers
        public CollectionObjective(string titleVerb, int totalAmount, GameObject item, string descrip)
        {
            title = titleVerb + " " + totalAmount + " " + item.name;
            description = descrip;
            itemToCollect = item;
            collectionAmount = totalAmount;
            currentAmount = 0;
        }

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

        public int CollectionAmount
        {
            get
            {
                return collectionAmount;
            }
        }

        public int CurrentAmount
        {
            get
            {
                return currentAmount;
            }
        }

        public GameObject ItemToCollect
        {
            get
            {
                return itemToCollect;
            }
        }



        public void CheckProgress()
        {
            throw new NotImplementedException();
        }

        public void UpdateProgress()
        {
            throw new NotImplementedException();
        }
    }
}
