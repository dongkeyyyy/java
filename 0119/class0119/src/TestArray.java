
public class TestArray {

	private int hap = 0;
	private double avg;
	
	
	public void arrhap(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			hap = arr[i] + hap;
		}
		System.out.println(hap);
	}
	
	public void arravg(int arr[]) {
		avg = (double)hap/arr.length;
		System.out.println(avg);
	}
	

	public TestArray(int arr[]) {
		super();
		arrhap(arr);
		arravg(arr);
		
		
	}

}
