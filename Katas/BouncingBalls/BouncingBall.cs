public class BouncingBall {
	
	public int Bounces(double h, double bounce, double window) {
      if (h <= 0) {
        return -1;
      }
      if (bounce <= 0 || bounce >= 1) {
        return -1;
      }
      if (window >= h) {
        return -1;
      }
      
      int isSeenCount = 0;
      
      isSeenCount++;
      double newHeight = h * bounce;
      if (newHeight >= window) {
        isSeenCount++;
        isSeenCount += Bounces(newHeight, bounce, window);
      }
	    return isSeenCount;
	}
}