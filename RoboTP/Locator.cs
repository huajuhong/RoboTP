using Microsoft.Extensions.DependencyInjection;
using RobotTeachPendant.ViewModel;

namespace RobotTeachPendant;

public class Locator
{
    public static Locator Instance { get; private set; }

    public Locator() { Instance = this; }

    public MainWindowViewModel MainWindowViewModel => App.Current.ServiceProvider.GetService<MainWindowViewModel>()!;
    public SequenceTabItemViewModel SequenceTabItemViewModel => App.Current.ServiceProvider.GetService<SequenceTabItemViewModel>()!;
    public PlateStackTabItemViewModel PlateStackTabItemViewModel => App.Current.ServiceProvider.GetService<PlateStackTabItemViewModel>()!;
    public HotelTabItemViewModel HotelTabItemViewModel => App.Current.ServiceProvider.GetService<HotelTabItemViewModel>()!;
    public LocationTabItemViewModel LocationTabItemViewModel => App.Current.ServiceProvider.GetService<LocationTabItemViewModel>()!;


}