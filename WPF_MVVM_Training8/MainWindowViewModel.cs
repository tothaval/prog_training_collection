using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_MVVM_Training8
{
    public class MainWindowViewModel
    {
        private readonly Microsoft.Extensions.Logging.ILogger _logger;
        private readonly Microsoft.Extensions.Logging.ILogger actionCommandLogger;
        private readonly ILoggerFactory _loggerFactory;
        private readonly ObservableCollection<ITab> tabs;

        public ICommand NewTabCommand { get; }

        public MainWindowViewModel(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
            _logger = _loggerFactory.CreateLogger<MainWindowViewModel>();

            LoggerConfiguration loggerConfiguration = new LoggerConfiguration()
                .WriteTo.File("loggingtest.log", rollingInterval: RollingInterval.Day)
                .MinimumLevel.Warning()
                .MinimumLevel.Override("WPF_MVVM_Training8", Serilog.Events.LogEventLevel.Debug);
                ;

            _loggerFactory.AddSerilog(loggerConfiguration.CreateLogger());


            ILogger<ActionCommand> actionCommandLogger = _loggerFactory.CreateLogger<ActionCommand>();


            //actionCommandLogger = _loggerFactory.CreateLogger<ActionCommand>();


            NewTabCommand = new ActionCommand(p => NewTab(actionCommandLogger));

            tabs = new ObservableCollection<ITab>();

            tabs.CollectionChanged += Tabs_CollectionChanged;

            Tabs = tabs;
        }

        public ICollection<ITab> Tabs { get; }

        private void NewTab(ILogger<ActionCommand> actionCommandLogger)
        {
            actionCommandLogger.LogWarning("creating a new tab on MainWindowView");
            Tabs.Add(new DateTab());
            actionCommandLogger.LogInformation("new tab on MainWindowView created");
        }

        private void Tabs_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            ITab tab;

            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    tab = (ITab)e.NewItems[0];
                    tab.CloseRequested += OnTabCloseRequested;
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    tab = (ITab)e.OldItems[0];
                    tab.CloseRequested -= OnTabCloseRequested;
                    break;
            }
        }

        private void OnTabCloseRequested(object? sender, EventArgs e)
        {
            Tabs.Remove((ITab)sender);
        }
    }
}
