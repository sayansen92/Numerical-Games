Problem: Given an array of integers, build a binary tree and find the greater subtree with respect to the root of the tree, i.e, left or right subtree.
Example: 	3,6,2,9,-1,10 
						  3
					    /	\
					   2 	 6
					  /		  \
					 -1  	   9
					 			\
					 			10

Here left subtree has 2, -1 i.e 2-1=1
whereas right subtree has 6, 9, 10 i.e 6+9+10=25

So here Right subtree is greater, hence return "Right".