using System;

namespace logical_exercise.LanguageDotNet
{
    public interface IEvent 
    {
        void LoadEventDetail();
    }

    public class TechEvents : IEvent
    {
        public void LoadEventDetail()
        {
            ConsoleUtility.WriteLine("Technology Event detail");
        }
    }

    public class FootballEvent: IEvent
    {
        public void LoadEventDetail() {
            ConsoleUtility.WriteLine("Footbal Event detail");
        }
    }

    public class PartyEvent: IEvent 
    {
        public void LoadEventDetail()
        {
            ConsoleUtility.WriteLine("Party Event Details");
        }
    }

    public class EventLocator
    {
        public IEvent LocateEvent(int index)
        {
            if (index == 1)
                return new FootballEvent();
            else if (index == 2)
                return new PartyEvent();
            else 
                return new TechEvents();
        }
    }

    public class College 
    {
        private IEvent _events = null;
        EventLocator el = new EventLocator();
        public College(int index){
            _events = el.LocateEvent(index);
        }

        public void GetEvent(){
            _events.LoadEventDetail();
        }
    }

    public static class IOCImplementation
    {
        public static void Run()
        {
            new College(1).GetEvent();
        }
    }



    // public class IOCImplementation
    // {
        
    // }
}