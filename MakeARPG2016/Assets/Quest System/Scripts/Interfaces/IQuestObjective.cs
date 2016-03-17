using UnityEngine;
using System.Collections;

namespace QuestSystem
{
    public interface IQuestObjective
    {
        string Title { get; }
        string Description { get; }
        void UpdateProgress();
        void CheckProgress();

    }
}
