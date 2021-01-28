import java.util.Scanner;

public class que4 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("영어 단어를 입력하세요");
		String pass = s.next();
		char a[] = new char[pass.length()];
		for (int i = 0; i < a.length; i++) {
			a[i] = pass.charAt(i);
		}
		char eng[] = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
				't', 'u', 'v', 'w', 'x' };
		char kor[] = { 'ㄱ', 'ㄴ', 'ㄷ', 'ㄹ', 'ㅁ', 'ㅂ', 'ㅅ', 'ㅇ', 'ㅈ', 'ㅊ', 'ㅋ', 'ㅌ', 'ㅍ', 'ㅎ', 'ㅏ', 'ㅑ', 'ㅓ', 'ㅕ', 'ㅗ',
				'ㅛ', 'ㅜ', 'ㅠ', 'ㅡ', 'ㅣ' };

		for (int i = 0; i < a.length; i++) {
			for (int j = 0; j < kor.length; j++) {
				if (a[i] == eng[j]) {
					System.out.println(kor[j]);
					break;
				}
			}
		}
	}
}

//
//			if (a[i] == 'a') {
//				System.out.print('ㄱ');
//			}
//			if (a[i] == 'b') {
//				System.out.print('ㄴ');
//			}
//			if (a[i] == 'c') {
//				System.out.print('ㄷ');
//			}
//			if (a[i] == 'd') {
//				System.out.print('ㄹ');
//			}
//			if (a[i] == 'd') {
//				System.out.print('ㅁ');
//			}
//			if (a[i] == 'f') {
//				System.out.print('ㅂ');
//			}
//			if (a[i] == 'g') {
//				System.out.print('ㅅ');
//			}
//			if (a[i] == 'h') {
//				System.out.print('ㅇ');
//			}
//			if (a[i] == 'i') {
//				System.out.print('ㅈ');
//			}
//			if (a[i] == 'j') {
//				System.out.print('ㅊ');
//			}
//			if (a[i] == 'k') {
//				System.out.print('ㅋ');
//			}
//			if (a[i] == 'l') {
//				System.out.print('ㅌ');
//			}
//			if (a[i] == 'm') {
//				System.out.print('ㅍ');
//			}
//			if (a[i] == 'n') {
//				System.out.print('ㅎ');
//			}
//			if (a[i] == 'o') {
//				System.out.print('ㅏ');
//			}
//			if (a[i] == 'p') {
//				System.out.print('ㅑ');
//			}
//			if (a[i] == 'q') {
//				System.out.print('ㅓ');
//			}
//			if (a[i] == 'r') {
//				System.out.print('ㅕ');
//			}
//			if (a[i] == 's') {
//				System.out.print('ㅗ');
//			}
//			if (a[i] == 't') {
//				System.out.print('ㅛ');
//			}
//			if (a[i] == 'u') {
//				System.out.print('ㅜ');
//			}
//			if (a[i] == 'v') {
//				System.out.print('ㅠ');
//			}
//			if (a[i] == 'w') {
//				System.out.print('ㅡ');
//			}
//			if (a[i] == 'x') {
//				System.out.print('ㅣ');
//			} else {
//				System.out.println("잘못 입력 하셨습니다");
//			}
//
