import { Component, Input, OnInit } from '@angular/core';
import { Color, ScaleType } from '@swimlane/ngx-charts';

@Component({
  selector: 'app-pie-chart',
  templateUrl: './pie-chart.component.html',
  styleUrls: ['./pie-chart.component.sass']
})
export class PieChartComponent implements OnInit {
  solved: number = 0; 
  @Input() CurrentNumber: number;
  @Input() TotalNumber: number;
  @Input() activeColor: string;
 
  

  single: any[] = [];
  colorScheme!: Color;
  

  view: [number, number] = [140, 140]; //height & width

  constructor(
  ) {

    Object.assign(this, { this: this.single });
  }

  ngOnInit(): void {
    this.solved = Math.floor(this.TotalNumber-this.CurrentNumber);
    this.single = [
      {
        "name": "Solved",
        "value": this.TotalNumber-this.CurrentNumber, 
      },
      {
        "name": "Total",
        "value": this.TotalNumber,
      },
    ];

    this.colorScheme = {
      name: 'myScheme',
      selectable: true,
      group: ScaleType.Ordinal,
      domain: [this.activeColor, '#F0F0F0']
    };
  }
}
