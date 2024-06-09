# Old Phone Keypad Functions
This project emulates the functionality of an old phone keypad, displaying messages based on user input.

## Description

It's an old phone keypad with alphabetical letters, a backspace key, and a send button. 
Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing
each button to represent more than one letter.
For example, pressing 2 once will return 'A' but pressing twice in succession will return 'B'.
You must pause for a second in order to type two characters from the same button after each other: "222 2 22" -> "CAB".

## Output Example
OldPhonePad("33#") => output: E
OldPhonePad("227*#") => output: B
OldPhonePad("4433555 555666#") => output: HELLO
OldPhonePad("8 88777444666*664#") => output: TURING

### Dependencies

.NET SDK 6.0 or higher.
Visual Studio 2022.
Standard .NET libraries (System, System.Collections.Generic).


### Installing and Executiing

- Download from https://github.com/KhaingLae/OldPhonePad_KLLS.git
- Open Visual Studio
- File >> Open Project >> Project/Solution >> Select the downloaded project
- Run OpenPhonePad 
  [OR]
  Run Unit Tests from OldPhonePhad.UnitTests


## Authors

Khaing Lae Lae Soe (khainglaelaesoe@gmail.com)


## Version History

* 0.1
    * Initial Release

## License

This project is an interview assignment project.

