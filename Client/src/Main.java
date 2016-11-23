import javax.swing.JFrame;

public class Main {
	public static void main(String[] args){
		System.out.println("start application");
		MainWindow mainWindow = new MainWindow();
		mainWindow.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		mainWindow.setSize(1080, 720);
		mainWindow.setVisible(true);
	}
}
