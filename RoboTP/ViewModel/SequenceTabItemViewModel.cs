using System.Collections.ObjectModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using MahApps.Metro.Controls;
using RobotTeachPendant.UserControl;

namespace RobotTeachPendant.ViewModel;

public class SequenceTabItemViewModel:ObservableObject
{

    /// <summary>
    /// 集合
    /// </summary>
    private ObservableCollection<Test> tests = new ObservableCollection<Test>()
    {
        new Test(){Name = "Get Plate From Storage Universal"} ,
        new Test(){Name = "Get Plate From TrashChute"} ,
        new Test(){Name = "Put Plate On Storage Universal"} ,
        new Test(){Name = "Put Plate On TrashChute"} ,
        new Test(){Name = "你是一个大傻瓜"} ,
        new Test(){Name = "我是一个大聪明"} ,
        new Test(){Name = "我是一个个个"} ,
        new Test(){Name = "你是一个不折不扣的大傻瓜"} ,
        new Test(){Name = "你是一个不折不扣的大傻瓜的同事"} ,
        new Test(){Name = "你是一个不折不扣的大傻瓜的朋友"} ,
        new Test(){Name = "你是一个不折不扣的大傻瓜的朋友的同事"} ,
        new Test(){Name = "你是一个神经病"} ,
    };

    /// <summary>
    /// 集合
    /// </summary>
    public ObservableCollection<Test> Tests
    {
        get => tests;
        set => SetProperty(ref tests, value);
    }
}

public class Test : ObservableObject, IBaseSearchModel
{
    /// <summary>
    /// 名字
    /// </summary>
    private string name;

    /// <summary>
    /// 名字
    /// </summary>
    public string Name
    {
        get => name;
        set => SetProperty(ref name, value);
    }

    /// <summary>
    /// 显示
    /// </summary>
    private Visibility visibility;

    /// <summary>
    /// 显示
    /// </summary>
    public Visibility Visibility
    {
        get => visibility;
        set => SetProperty(ref visibility, value);
    }
}