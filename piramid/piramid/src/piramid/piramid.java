package piramid;

import java.util.Scanner;

public class piramid {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		
		System.out.println("피라미드의 높이를 설정하세요!");
        int height = Integer.parseInt(s.nextLine());
        
        for(int q = 0 ; q < height ; q++) {
            int space = height - (q + 1);
            int width = q * 2 + 1;
            
            for(int w = 0 ; w < space ; w++) System.out.print(" ");
            for(int w = 0 ; w < width ; w++) System.out.print("*");
            System.out.println();
        }
        s.close();
	}
}
