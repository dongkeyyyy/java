package loop1222;

public class Array1 {

	public static void main(String[] args) {
		int[] ar1 = new int[5];  // 길이가 5인 int형 1차원 배열의 생성
		
		double[] ar2 = new double[7]; // 길이가 7인 double형 1차원 배열의 생성
		
		float[] ar3;  // 배열의 참조변수와 인스턴스 생성 분리
		ar3 = new float[9];
		
		System.out.println("배열 ar1 길이 : " + ar1.length);
		System.out.println("배열 ar2 길이 : " + ar2.length);
		System.out.println("배열 ar3 길이 : " + ar3.length);
	}

}
