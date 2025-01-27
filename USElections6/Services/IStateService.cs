using System.Reactive.Subjects;

namespace USElections6.State
{
    public interface IStateService
    {
        public BehaviorSubject<double> CurrentlyChosenYear { get; set; }
    }
}
