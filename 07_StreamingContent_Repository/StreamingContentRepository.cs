using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD methods below

        public bool AddContentToDirectory(StreamingContent newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
    }
}
