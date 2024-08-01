using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;

namespace RobotTeachPendant
{
    public class MainWindowViewModel : ObservableObject
    {
        /// <summary>
        /// 机械臂集合
        /// </summary>
        private ObservableCollection<Robot> robots = new ObservableCollection<Robot>();

        /// <summary>
        /// 机械臂集合
        /// </summary>
        public ObservableCollection<Robot> Robots
        {
            get => robots;
            set => SetProperty(ref robots, value);
        }


        /// <summary>
        /// 选中的机械臂
        /// </summary>
        private Robot selectedRobot;

        /// <summary>
        /// 选中的机械臂
        /// </summary>
        public Robot SelectedRobot
        {
            get => selectedRobot;
            set => SetProperty(ref selectedRobot, value);
        }

        /// <summary>
        /// 设置机械臂参数命令
        /// </summary>
        public ICommand SetRobotParameterCommand => new RelayCommand(ExecuteSetRobotParameterCommand);

        /// <summary>
        /// 执行设置机械臂参数命令
        /// </summary>
        private void ExecuteSetRobotParameterCommand()
        {

        }

        /// <summary>
        /// 是否自由模式
        /// </summary>
        private bool isFreeMode;

        /// <summary>
        /// 是否自由模式
        /// </summary>
        public bool IsFreeMode
        {
            get => isFreeMode;
            set => SetProperty(ref isFreeMode, value);
        }

        /// <summary>
        /// Ping机械臂命令
        /// </summary>
        public ICommand PingRobotCommand => new RelayCommand(ExecutePingRobotCommand);

        /// <summary>
        /// 执行Ping机械臂命令
        /// </summary>
        private void ExecutePingRobotCommand()
        {

        }

        /// <summary>
        /// 连接机械臂命令
        /// </summary>
        public ICommand ConnectRobotCommand => new RelayCommand(ExecuteConnectRobotCommand);

        /// <summary>
        /// 执行连接机械臂命令
        /// </summary>
        private void ExecuteConnectRobotCommand()
        {

        }

        /// <summary>
        /// 机械臂状态
        /// </summary>
        private RobotStatus robotStatus;

        /// <summary>
        /// 机械臂状态
        /// </summary>
        public RobotStatus RobotStatus
        {
            get => robotStatus;
            set => SetProperty(ref robotStatus, value);
        }

        /// <summary>
        /// 夹爪集合
        /// </summary>
        private ObservableCollection<Grip> grips;

        /// <summary>
        /// 夹爪集合
        /// </summary>
        public ObservableCollection<Grip> Grips
        {
            get => grips;
            set => SetProperty(ref grips, value);
        }

        /// <summary>
        /// 设置夹爪参数命令
        /// </summary>
        public ICommand SetGripParameterCommand => new RelayCommand(ExecuteSetGripParameterCommand);

        /// <summary>
        /// 执行设置夹爪参数命令
        /// </summary>
        private void ExecuteSetGripParameterCommand()
        {

        }

        /// <summary>
        /// 是否使用夹爪
        /// </summary>
        private bool isUseGrip;

        /// <summary>
        /// 是否使用夹爪
        /// </summary>
        public bool IsUseGrip
        {
            get => isUseGrip;
            set => SetProperty(ref isUseGrip, value);
        }

        /// <summary>
        /// 打开夹爪命令
        /// </summary>
        public ICommand OpenGripCommand => new RelayCommand(ExecuteOpenGripCommand);

        /// <summary>
        /// 执行打开夹爪命令
        /// </summary>
        private void ExecuteOpenGripCommand()
        {

        }

        /// <summary>
        /// 关闭夹爪命令
        /// </summary>
        public ICommand CloseGripCommand => new RelayCommand(ExecuteCloseGripCommand);

        /// <summary>
        /// 执行关闭夹爪命令
        /// </summary>
        private void ExecuteCloseGripCommand()
        {

        }
    }
}
