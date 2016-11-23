import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.Toolkit;
import java.util.Timer;
import java.util.TimerTask;
import javax.swing.JButton;
import javax.swing.JFrame;
import java.util.Scanner;
import java.util.Timer;
import java.util.TimerTask;

public class LoadWindow extends JFrame {
	 static int interval;
	 static Timer timer;
	private static final long serialVersionUID = 5429826383952515111L;
	public LoadWindow() {
	this.setUndecorated(true);
	this.setSize(300, 400);
	this.setVisible(true);
	Dimension dim = Toolkit.getDefaultToolkit().getScreenSize();
	this.setLocation(dim.width/2-this.getSize().width/2, dim.height/2-this.getSize().height/2);
	

	
	  Scanner sc = new Scanner(System.in);
	    System.out.print("Input seconds => : ");
	    String secs = sc.nextLine();
	    int delay = 1000;
	    int period = 1000;
	    timer = new Timer();
	    interval = Integer.parseInt(secs);
	    System.out.println(secs);
	    timer.scheduleAtFixedRate(new TimerTask() {

	        public void run() {
	            System.out.println(setInterval());

	        }
	    }, delay, period);
	}

	private static final int setInterval() {
	    if (interval == 1)
	        timer.cancel();
	    return --interval;
	}
	
	}

