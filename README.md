# Caesar Shift

## Overview
A Windows Forms application used to decipher Caesar cipher encoded text. The application allows users to either manually enter a shift value to decode text, or use an auto detect feature to automatically identify the correct shift without prior knowledge of the shift value.

## What is a Caesar Cipher?
A Caesar cipher is one of the oldest encryption techniques. Each letter in the text is shifted by a fixed number of positions in the alphabet. For example, with a shift of 3, the letter A becomes D, B becomes E, and so on. To decipher the text, the letters are shifted back by the same amount.

## Features
The application provides two methods of deciphering Caesar cipher text. The first method allows the user to manually enter a shift value between 1 and 25 and decode the cipher text directly. The second method uses frequency analysis to automatically detect the most likely shift value without requiring user input.

## How to Use
The cipher text is entered into the Original Text box. A shift value between 1 and 25 can then be entered and the Decipher button clicked to decode the text. Alternatively, the Decipher All button can be used to automatically detect the correct shift and display the most likely result.

## How Auto Detect Works
The auto detect feature uses frequency analysis to identify the correct shift. In English, certain letters appear more frequently than others, with E being the most common at 12.7%, followed by T, A and O. The application tries all 25 possible shifts and scores each result based on how closely the letter frequencies match typical English text. The highest scoring result is returned as the best guess. The auto detect feature works best on longer texts, as shorter phrases may not contain enough letters to produce an accurate result. (Practicalcryptography.com, 2009)

## Limitations
The auto detect feature requires a minimun of 20 characters to produce and accurate result. Short phrases do not contain enough letters for
frequency analysis to reliably identify the correct shift. For short texts, the manual shift value should be used instead.

## Requirements
- Windows
- .NET Framework 4.7.2
- Visual Studio 2026 Community (v18.7.3)

## How to Run
1. Clone the repository
2. Open `Caesar_shift.sln` in Visual Studio
3. Build and run the project

## References:

Practicalcryptography.com. (2009). Practical Cryptography. [online] Available at: http://practicalcryptography.com/cryptanalysis/letter-frequencies-various-languages/english-letter-frequencies/ [Accessed 9 July 2026].
