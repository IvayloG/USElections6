using System.Reactive.Subjects;

namespace USElections6.State
{
    public class MockStateService : IStateService
    {
        public BehaviorSubject<double> CurrentlyChosenYear { get; set; } = new(2024);
    }
}
