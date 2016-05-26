Class MainWindow 
    'Dim map1_opac,map2_opac,map3_opac,map4_opac,map5_opac,map1_opac,map1_opac,map1_opac,map1_opac,map1_opac As Double







    Private Sub Slider1_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider1.ValueChanged
        Image1.Opacity = Slider1.Value

    End Sub

    Private Sub Slider2_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider2.ValueChanged
        Image2.Opacity = Slider2.Value

    End Sub

    Private Sub Slider3_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider3.ValueChanged
        Image3.Opacity = Slider3.Value

    End Sub

    Private Sub Slider4_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider4.ValueChanged
        Image4.Opacity = Slider4.Value

    End Sub

    Private Sub Slider5_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider5.ValueChanged
        Image5.Opacity = Slider5.Value

    End Sub

    Private Sub Slider6_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider6.ValueChanged
        Image6.Opacity = Slider6.Value

    End Sub

    Private Sub Slider7_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider7.ValueChanged
        Image7.Opacity = Slider7.Value

    End Sub

    Private Sub Slider8_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider8.ValueChanged
        Image8.Opacity = Slider8.Value

    End Sub

    Private Sub Slider9_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider9.ValueChanged
        Image9.Opacity = Slider9.Value

    End Sub

    Private Sub Slider10_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider10.ValueChanged
        Image10.Opacity = Slider10.Value

    End Sub

    Private Sub Slider11_ValueChanged(sender As Object, e As System.Windows.RoutedPropertyChangedEventArgs(Of Double)) Handles Slider11.ValueChanged
        Image11.Opacity = Slider11.Value

    End Sub

    Private Sub CheckBox1_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox1.Checked
        Image1.Visibility = Windows.Visibility.Visible
        Slider1.IsEnabled = True
    End Sub

    Private Sub CheckBox1_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox1.Unchecked
        Image1.Visibility = Windows.Visibility.Hidden
        Slider1.IsEnabled = False
    End Sub

    Private Sub CheckBox2_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox2.Checked
        Image2.Visibility = Windows.Visibility.Visible
        Slider2.IsEnabled = True
    End Sub

    Private Sub CheckBox2_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox2.Unchecked
        Image2.Visibility = Windows.Visibility.Hidden
        Slider2.IsEnabled = False
    End Sub

    Private Sub CheckBox3_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox3.Checked
        Image3.Visibility = Windows.Visibility.Visible
        Slider3.IsEnabled = True
    End Sub

    Private Sub CheckBox3_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox3.Unchecked
        Image3.Visibility = Windows.Visibility.Hidden
        Slider3.IsEnabled = False
    End Sub

    Private Sub CheckBox4_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox4.Checked
        Image4.Visibility = Windows.Visibility.Visible
        Slider4.IsEnabled = True
    End Sub

    Private Sub CheckBox4_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox4.Unchecked
        Image4.Visibility = Windows.Visibility.Hidden
        Slider4.IsEnabled = False
    End Sub

    Private Sub CheckBox5_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox5.Checked
        Image5.Visibility = Windows.Visibility.Visible
        Slider5.IsEnabled = True
    End Sub

    Private Sub CheckBox5_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox5.Unchecked
        Image5.Visibility = Windows.Visibility.Hidden
        Slider5.IsEnabled = False
    End Sub

    Private Sub CheckBox6_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox6.Checked
        Image6.Visibility = Windows.Visibility.Visible
        Slider6.IsEnabled = True
    End Sub

    Private Sub CheckBox6_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox6.Unchecked
        Image6.Visibility = Windows.Visibility.Hidden
        Slider6.IsEnabled = False
    End Sub

    Private Sub CheckBox7_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox7.Checked
        Image7.Visibility = Windows.Visibility.Visible
        Slider7.IsEnabled = True
    End Sub

    Private Sub CheckBox7_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox7.Unchecked
        Image7.Visibility = Windows.Visibility.Hidden
        Slider7.IsEnabled = False
    End Sub

    Private Sub CheckBox8_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox8.Checked
        Image8.Visibility = Windows.Visibility.Visible
        Slider8.IsEnabled = True
    End Sub

    Private Sub CheckBox8_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox8.Unchecked
        Image8.Visibility = Windows.Visibility.Hidden
        Slider8.IsEnabled = False
    End Sub

    Private Sub CheckBox9_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox9.Checked
        Image9.Visibility = Windows.Visibility.Visible
        Slider9.IsEnabled = True
    End Sub

    Private Sub CheckBox9_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox9.Unchecked
        Image9.Visibility = Windows.Visibility.Hidden
        Slider9.IsEnabled = False
    End Sub

    Private Sub CheckBox10_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox10.Checked
        Image10.Visibility = Windows.Visibility.Visible
        Slider10.IsEnabled = True
    End Sub

    Private Sub CheckBox10_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox10.Unchecked
        Image10.Visibility = Windows.Visibility.Hidden
        Slider10.IsEnabled = False
    End Sub

    Private Sub CheckBox11_Checked(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles CheckBox11.Checked
        Image11.Visibility = Windows.Visibility.Visible
        Slider11.IsEnabled = True
    End Sub

    Private Sub CheckBox11_Unchecked(sender As Object, e As System.Windows.RoutedEventArgs) Handles CheckBox11.Unchecked
        Image11.Visibility = Windows.Visibility.Hidden
        Slider11.IsEnabled = False
    End Sub




    Private Sub Button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs)

    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("http://digitalcollections.nypl.org/items/75058670-f3a2-0130-4cc1-58d385a7b928")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("http://digitalcollections.nypl.org/items/340c4540-d350-012f-2c90-58d385a7b928")
    End Sub


    Private Sub Button5_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("http://digitalcollections.nypl.org/items/20d2f230-d2ac-012f-3549-58d385a7bbd0")
    End Sub


    Private Sub Button6_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("http://digitalcollections.nypl.org/items/9defba10-d299-012f-0a03-58d385a7bbd0")

    End Sub


    Private Sub Button7_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("http://digitalcollections.nypl.org/items/ad8f6ba0-d296-012f-6380-58d385a7bbd0")
    End Sub


    Private Sub Button8_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button8.Click
        System.Diagnostics.Process.Start("http://digitalcollections.nypl.org/items/c42cb93f-8db8-ca65-e040-e00a18064e5c")
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button9.Click
        System.Diagnostics.Process.Start("http://digitalcollections.nypl.org/items/c6d9ae6e-07ab-24cf-e040-e00a18060887")
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button10.Click
        System.Diagnostics.Process.Start("http://digitalcollections.nypl.org/items/510d47da-ee3b-a3d9-e040-e00a18064a99")
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button11.Click
        System.Diagnostics.Process.Start("http://digitalcollections.nypl.org/items/871fda48-ba46-c1d9-e040-e00a18064c0a")
    End Sub
End Class
