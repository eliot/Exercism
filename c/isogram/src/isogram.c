#include <stdio.h>
#include <ctype.h>
#include <stdbool.h>

bool is_isogram(const char phrase[]) {
	printf("%s", phrase);
	// handle NULL
	if (phrase == NULL)
		return false;

	// lookup table for character tally
	int count[26];

	char *c = (char *)phrase;
	// count occurrences of each letter

	int str_length = 0;
	
	while (*c) {
		str_length++;

		// convert to lowercase
		int ascii_code = (int) tolower(*c);

		// only add alphabetic characters
		if (ascii_code >= 97 && ascii_code <= 122)
			count[ascii_code - 97] = count[ascii_code - 97] + 1;
		 
		c++;
	}

	// handle empty string
	if (str_length < 1)
		return true;

	// check if isogram
	for (int i = 0; i < 26; i++) {

		// if a letter occurs more than once, it is not an isogram
		if (count[i] > 1)
			return false;
	}
	return true;
}
