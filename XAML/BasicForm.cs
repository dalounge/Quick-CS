<Window x:Class="WPFUI.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WPFUI"
        mc:Ignorable="d" FontSize="18"
        Title="Our WPF Demo" Height="450" Width="800">
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="20" />
            <ColumnDefinition Width="auto" />
            <ColumnDefinition Width="auto" />
            <ColumnDefinition Width="auto" />
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="20" />
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="20" />
            <RowDefinition Height="auto" />
            <RowDefinition Height="auto" />
            <RowDefinition Height="auto" />
            <RowDefinition Height="auto" />
            <RowDefinition Height="auto" />
            <RowDefinition Height="*" />
            <RowDefinition Height="20" />
        </Grid.RowDefinitions>
        <TextBlock Grid.Column="1" Grid.Row="1" 
                   Text="Trigger these events" FontFamily="Segoe Print"
                   Grid.ColumnSpan="2"
                   Margin="20,0,0,10"/>

        <TextBlock Grid.Column="1" Grid.Row="2" FontWeight="Bold"
                   Text="First Name" />

        <TextBox x:Name="firstNameText" Grid.Column="2" Grid.Row="2"
                 Width="150" Margin="10,0"/>

        <Button x:Name="submitButton" Content="Run Me"
                Grid.Column="1"
                Grid.Row="3"
                Margin="10" Grid.ColumnSpan="2" Click="SubmitButton_Click"/>
    </Grid>
</Window>
