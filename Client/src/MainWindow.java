import javax.swing.JFrame;
import javax.swing.JButton;
import java.awt.*;

public class MainWindow extends JFrame{
	private static final long serialVersionUID = 5429826383952515111L;
	JButton btn;
	MainPanel pnl;
	public MainWindow(){
		super("Title Bar");
		setLayout(new BorderLayout());
		pnl = new MainPanel();
		btn = new JButton("Button");
		pnl.add(btn);
		add(pnl, BorderLayout.CENTER);
		pack();
	}
}
