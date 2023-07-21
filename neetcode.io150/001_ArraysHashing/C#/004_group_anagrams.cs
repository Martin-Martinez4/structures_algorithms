public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        //Brute Force

        Dictionary<string, int> groupTracker = new Dictionary<string, int>();

        List<List<string>> groupArray = new List<IList<string>>();

        foreach(string word in strs)
        {
            string sortedWord = String.Concat(word.OrderBy(c => c));

            if(groupTracker.ContainsKey(sortedWord))
            {
                groupArray[groupTracker[sortedWord]].Add(word);
            }
            else
            {

                groupTracker[sortedWord] = groupArray.Count;
                groupArray.Add(new List<string>(word));
            }

        }

        return groupArray;
        
    }
    public IList<IList<string>> GroupAnagrams2(string[] strs) {

        Dictionary<string, IList<string>> groupTracker = new Dictionary<string, IList<string>>();

        foreach(string word in strs)
        {
            string sortedWord = String.Concat(word.OrderBy(c => c));

            if(groupTracker.ContainsKey(sortedWord))
            {
                groupTracker[sortedWord].Add(word);
            }
            else
            {

                groupTracker[sortedWord] = new List<string>(){word};
            }

        }

        return groupTracker.Values.ToList();
        
    }
}