import java.util.Scanner;

public class que2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("년도를 입력해주세요");
		int year = s.nextInt();
		
		if(year%12 == 0) {
			System.out.println("원숭이띠");
		}
		if(year%12 == 1) {
			System.out.println("닭띠");
		}
		if(year%12 == 2) {
			System.out.println("개띠");
		}
		if(year%12 == 3) {
			System.out.println("돼지띠");
		}
		if(year%12 == 4) {
			System.out.println("쥐띠");
		}
		if(year%12 == 5) {
			System.out.println("소띠");
		}
		if(year%12 == 6) {
			System.out.println("호랑이띠");
		}
		if(year%12 == 7) {
			System.out.println("토끼띠");
		}
		if(year%12 == 8) {
			System.out.println("용띠");
		}
		if(year%12 == 9) {
			System.out.println("뱀띠");
		}
		if(year%12 == 10) {
			System.out.println("말띠");
		}
		if(year%12 == 11) {
			System.out.println("양띠");
		}
		s.close();
	}

}
