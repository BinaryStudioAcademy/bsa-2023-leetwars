import { Component, Input, OnInit } from '@angular/core';
import { Color, ScaleType } from '@swimlane/ngx-charts';

@Component({
  selector: 'app-pie-chart',
  templateUrl: './pie-chart.component.html',
  styleUrls: ['./pie-chart.component.sass']
})
export class PieChartComponent implements OnInit {
  solved: number = 0; //our text in the middle of the pie
  @Input() CurrentNumber: number = 0;
  @Input() TotalNumber: number = 0;
  @Input() PieTitle: string = 'Pie Chart';
  @Input() activeColor: string = '#000';
 
  

  single: any[] = [];
  colorScheme!: Color;
  

  view: [number, number] = [184, 184]; //height & width

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
