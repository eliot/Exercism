#include <stdio.h>
#include <ctype.h>
#include <stdbool.h>

// offset alphabet to be 0..26 instead of 97..122
#define ASCII_OFFSET 97

bool is_isogram(const char phrase[]) {
    
	// handle NULL case
	if (phrase == NULL)
		return false;

	// lookup table for character tally
    int count[26] = {0};

	for (char *c = (char *)phrase; *c; c++) {

		// convert to lowercase
		int ascii_code = (int) tolower(*c);

		// only count alphabetic characters
		if (isalpha(*c))
			count[ascii_code - ASCII_OFFSET] = count[ascii_code - ASCII_OFFSET] + 1;
		
	}

	// check if isogram
	for (int i = 0; i < 26; i++) {

		// if a letter occurs more than once, it is not an isogram
		if (count[i] > 1)
			return false;
	}
	return true;
}
