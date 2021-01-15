
public class ArrayMain {

	public static void main(String[] args) {
		int arr[] = { 10, 20, 30, 40, 50,
					  60, 70, 80, 90, 100 };
		ArrayHap hap = new ArrayHap(arr);
		System.out.println("배열의 합 : " + hap.getSum());
		System.out.println("배열의 평균 : " + hap.getAvg());
	}

}

class ArrayHap {  
	// 배열의 합과 평균을 속성으로 설정
	private int sum;
	private int avg; 
	
	public ArrayHap(int arr[]) {
		for (int i : arr) {  // int i : arr = i가 0이면 arr[0]  i가 2이면 arr[2]  i 는 데이터 값 그 자체의 변수가 됨
			sum += i;
		}
		avg = sum / arr.length;
		System.out.println("배열의 합 : " + sum);
		System.out.println("배열의 평균 : " + avg);
	}

	// 합과 평균을 반환하는 인스턴스 메쏘드
	public int getSum() {
		return sum;
	}
	public int getAvg() {
		return avg;
	}
	
	
}
