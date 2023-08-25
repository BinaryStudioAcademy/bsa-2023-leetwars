import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-progress-bar',
  templateUrl: './progress-bar.component.html',
  styleUrls: ['./progress-bar.component.sass']
})
export class ProgressBarComponent implements OnInit {

  @Input() max: number;
  @Input() value: number;
  @Input() type: string;
  @Input() striped: boolean = true;
  @Input() animate: boolean;
  constructor() { }

  ngOnInit(): void {
  }

}
