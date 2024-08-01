using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Extensions.DependencyInjection;
using RobotTeachPendant.View;
using RobotTeachPendant.ViewModel;

namespace RobotTeachPendant
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }
        public ServiceCollection ServiceCollection { get; set; }

        public new static App Current => (App)Application.Current;
        public static Dispatcher MainDispatcher => Application.Current?.Dispatcher;

        protected override void OnStartup(StartupEventArgs e)
        {
            //UI线程未捕获异常处理事件
            base.DispatcherUnhandledException += App_DispatcherUnhandledException;

            //Task线程内未捕获异常处理事件
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

            //非UI线程未捕获异常处理事件
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Dispatcher.CurrentDispatcher.UnhandledException += CurrentDispatcher_UnhandledException;

            ServiceCollection = new ServiceCollection();
            ConfigureServices(ServiceCollection);
            ServiceProvider = ServiceCollection.BuildServiceProvider();
            base.OnStartup(e);
        }

        private void ConfigureServices(ServiceCollection service)
        {
            service.AddSingleton<MainWindowViewModel>();
            service.AddSingleton<SequenceTabItemViewModel>();
            service.AddSingleton<HotelTabItemViewModel>();
            service.AddSingleton<LocationTabItemViewModel>();
            service.AddSingleton<PlateStackTabItemViewModel>();
        }

        private void CurrentDispatcher_UnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
        }

        private void TaskScheduler_UnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
        {
        }

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
        }
    }

}
