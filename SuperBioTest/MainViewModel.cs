using System.Collections.ObjectModel;
using ViewModel;

namespace SuperBioTest
{
  class MainViewModel : BindableBase
  {
    private ObservableCollection<ReagentRack> reagentRacks = new ObservableCollection<ReagentRack>();

    public ObservableCollection<ReagentRack> ReagentRacks
    {
      get { return reagentRacks; }
      set
      {
        SetProperty(ref reagentRacks, value);
      }
    }
    private ObservableCollection<SampleRack> sampleRacks = new ObservableCollection<SampleRack>();

    public ObservableCollection<SampleRack> SampleRacks
    {
      get { return sampleRacks; }
      set
      {
        SetProperty(ref sampleRacks, value);
      }
    }
    public MainViewModel()
    {
      SampleRacks.Add(
        new SampleRack {
            new Sample { Name = "Blood", Volume=100, Patient="Jean"},
            new Sample { Name = "Blood", Volume=100, Patient="Sylvie"},
            new Sample { Name = "Blood", Volume=100, Patient="Marc"},
            new Sample { Name = "Blood", Volume=100, Patient="Valérie"},
          }
        );
      SampleRacks.Add(
          new SampleRack {
            new Sample { Name = "Plasma", Volume=100, Patient="Jean"},
            new Sample { Name = "Plasma", Volume=100, Patient="Sylvie"},
            new Sample { Name = "Plasma", Volume=100, Patient="Marc"},
            new Sample { Name = "Plasma", Volume=100, Patient="Valérie"},
          }
        );

      ReagentRacks.Add(
      new ReagentRack {
            new Reagent { Name = "Covid19", Volume=100 },
            new Reagent { Name = "Covid19", Volume=100 },
            new Reagent { Name = "Covid19", Volume=100 },
            new Reagent { Name = "Covid19", Volume=100 },
        }
      );
      ReagentRacks.Add(
          new ReagentRack {
            new Reagent { Name = "Insulina", Volume=100 },
            new Reagent { Name = "Insulina", Volume=100 },
            new Reagent { Name = "Insulina", Volume=100 },
            new Reagent { Name = "Insulina", Volume=100 },
          }
        );
    }
  }
}
