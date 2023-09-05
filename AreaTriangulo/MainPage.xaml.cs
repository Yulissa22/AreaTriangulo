namespace AreaTriangulo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	private void btncalcular_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(A.Text) && !string.IsNullOrEmpty(B.Text) &&
		!string.IsNullOrEmpty(C.Text))
		{
			double ladoA, ladoB, ladoC, area, semiperimetro;
			ladoA = Convert.ToInt32(A.Text);
			ladoB = Convert.ToInt32(B.Text);
			ladoC = Convert.ToInt32(C.Text);

			semiperimetro = (ladoA + ladoB + ladoC) /2;

			area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

			Area.Text=area.ToString("N2");

		}
		else
		{
			DisplayAlert("Error", "Ocurrio un error al introducir el dato", "OK");
		}
	}
}

