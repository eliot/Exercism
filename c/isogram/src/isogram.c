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

		// only count alpha chars
		if (isalpha(*c)) {
			// letter has not occurred before
			if (count[ascii_code - ASCII_OFFSET] == 0)
				count[ascii_code - ASCII_OFFSET]++;
			// letter has been seen before; not an isogram
			else
				return false;
		}
	}

	return true;
}
