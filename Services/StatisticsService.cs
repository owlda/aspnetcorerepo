using System.Collections;

namespace apsnetproject.Services
{
    public class StatisticsService
    {

         private readonly ArrayList _toDoItemRepository;
        public StatisticsService(ArrayList _listData)
        {
            _toDoItemRepository = _listData;
        }

        public void GetCount(){}
        public void ShowStats(){}
    }
}