import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-solution',
  templateUrl: './solution.component.html',
  styleUrls: ['./solution.component.sass']
})
export class SolutionComponent implements OnInit {
  selectedLanguage: string = 'C#';
  selectedVersion: string = 'Version 1';

  switchTab(tab: string) {
    
  }

  constructor() { }

  ngOnInit(): void {
  }

}
