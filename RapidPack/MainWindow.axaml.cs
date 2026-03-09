using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Globalization;

namespace RapidPack;

public partial class MainWindow : Window
{
    
    private readonly ParcelCalculator _calculator = new ParcelCalculator();

    public MainWindow()
    {
        InitializeComponent();
    }


    public void OnCalculateClick(object? sender, RoutedEventArgs e)
    {
        try
        {
           
            if (!double.TryParse(WeightTextBox.Text,  out double weight) ||
                !double.TryParse(HeightTextBox.Text,  out double height) ||
                !double.TryParse(WidthTextBox.Text,  out double width) ||
                !double.TryParse(DepthTextBox.Text, out double depth))
            {
                ResultTextBlock.Text = " Błąd: Wszystkie wymiary i waga muszą być liczbami!";
                return;
            }

          
            bool isExpress = ExpressCheckBox.IsChecked ?? false;

           
            var selectedItem = ShipmentTypeComboBox.SelectedItem as ComboBoxItem;
            string shipmentType = selectedItem?.Content?.ToString() ?? "Standardowa";

           
            double finalPrice = _calculator.CalculatePrice(weight, height, width, depth, isExpress, shipmentType);

            
            ResultTextBlock.Text = $" Podsumowanie:\n" +
                                   $"Typ: {shipmentType}\n" +
                                   $"Waga: {weight} kg | Suma wym.: {height + width + depth} cm\n" +
                                   $"CENA: {finalPrice:0.00} zł";
        }
        catch (ArgumentException ex)
        {
            ResultTextBlock.Text = $" Uwaga: {ex.Message}";
        }
        catch (Exception)
        {
            ResultTextBlock.Text = " Wystąpił nieoczekiwany błąd aplikacji.";
        }
    }
}