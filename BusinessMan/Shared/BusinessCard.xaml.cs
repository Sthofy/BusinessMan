namespace BusinessMan.Shared;

public partial class BusinessCard : ContentView
{
    public static readonly BindableProperty BusinessNameProperty =
        BindableProperty.Create(nameof(BusinessName), typeof(string),
            typeof(BusinessCard), string.Empty);

    public static readonly BindableProperty BusinessTypeProperty =
        BindableProperty.Create(nameof(BusinessType), typeof(string),
            typeof(BusinessCard), string.Empty);

    public static readonly BindableProperty BusinessImageSourceProperty =
        BindableProperty.Create(nameof(BusinessImageSource), typeof(string),
            typeof(BusinessCard), string.Empty);

    public static readonly BindableProperty IncomeProperty =
        BindableProperty.Create(nameof(Income), typeof(string),
            typeof(BusinessCard), string.Empty);

    public static readonly BindableProperty NavigateImageProperty =
        BindableProperty.Create(nameof(NavigateImageSource), typeof(string),
            typeof(BusinessCard), string.Empty);

    public string BusinessName
    {
        get => (string)GetValue(BusinessCard.BusinessNameProperty);
        set => SetValue(BusinessCard.BusinessNameProperty, value);
    }
    public string BusinessType
    {
        get => (string)GetValue(BusinessCard.BusinessTypeProperty);
        set => SetValue(BusinessCard.BusinessTypeProperty, value);
    }
    public string BusinessImageSource
    {
        get => (string)GetValue(BusinessCard.BusinessImageSourceProperty);
        set => SetValue(BusinessCard.BusinessImageSourceProperty, value);
    }
    public string Income
    {
        get => (string)GetValue(BusinessCard.IncomeProperty);
        set => SetValue(BusinessCard.IncomeProperty, value);
    }
    public string NavigateImageSource
    {
        get => (string)GetValue(BusinessCard.NavigateImageProperty);
        set => SetValue(BusinessCard.NavigateImageProperty, value);
    }

    public BusinessCard()
    {
        InitializeComponent();
    }
}