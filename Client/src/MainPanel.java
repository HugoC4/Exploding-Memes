import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.RadialGradientPaint;
import java.awt.RenderingHints;

import javax.swing.JPanel;

public class MainPanel extends JPanel{
	private static final long serialVersionUID = 3247003615529492264L;

	@Override
    public void paintComponent(Graphics g) {
	    super.paintComponent(g);
	    Graphics2D g2d = (Graphics2D) g;
	    
	    g2d.setRenderingHint(RenderingHints.KEY_RENDERING, RenderingHints.VALUE_RENDER_QUALITY);
	    
	    Point center = new Point(super.getWidth() / 2,super.getHeight() / 2);//center of panel
	    int w = getWidth(); // width of panel
	    int h = getHeight(); //hight of panel
		float radius = 800; // size of inner circle
		float[] dist = {0.0f, 1.0f}; //how strong the colors are
		Color[] colors = {Color.cyan, Color.blue}; //colors
		
		//radial gradient paint.
		RadialGradientPaint p = new RadialGradientPaint(center, radius, dist, colors); 
	    //set paint
		g2d.setPaint(p);
		//fill whole rectangle with the paint.
	    g2d.fillRect(0, 0, w, h);
    }
}
