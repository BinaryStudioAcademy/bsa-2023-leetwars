import { Component, Input } from '@angular/core';
import { faEye, faEyeSlash } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-suggested-challenge',
  templateUrl: './suggested-challenge.component.html',
  styleUrls: ['./suggested-challenge.component.sass']
})
export class SuggestedChallengeComponent {
  @Input() tags: string[] = ['Algorithms', 'Strings', 'Data Types', 'Formatting', 'Logic', 'Graph', 'Stack'];
  @Input() constraints: string[] = [
    'Strings passed in will consist of only letters and spaces.',
    'Spaces will be included only when more than one word is present.',
    'Some another constraint.',
    'Some another constraint.',
    'Some another constraint.'
  ];

  @Input() languages: string[] = [
    'C#',
    'C++',
    'C',
    'Java',
    'Javascript',
    'Typescript'
  ]

  score: string[] = [
    'Rank up',
    'Rank down'
  ]

  @Input() description: string = 'Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter, words reversed.';
  @Input() title: string = 'Stop gninnipS My sdroW!';
  @Input() difficulty: string = '6 kyu'

  onMouseWheel(event: WheelEvent): void {
    
    const container = document.querySelector('.tags');
    if (container) {
      container.scrollLeft += event.deltaY;
      event.preventDefault();
    }
  }
}
