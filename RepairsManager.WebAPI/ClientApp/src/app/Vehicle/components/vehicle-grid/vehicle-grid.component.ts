import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { vehicleModel } from '../../models/VehicleModel';
import { VehicleService } from '../../services/vehicle.service';

@Component({
  selector: 'app-vehicle-grid',
  templateUrl: './vehicle-grid.component.html',
  styleUrls: ['./vehicle-grid.component.scss'],
  providers: [ VehicleService ]
})
export class VehicleGridComponent implements OnInit {

  private vehilces: Observable<Array<vehicleModel>>;
  private selectedVehicle: vehicleModel;

  cols: any[] = [
    { field: 'id', header: '#' },
    { field: 'markName', header: 'Марка' },
    { field: 'modelName', header: 'Модель' },
    { field: 'regNumber', header: 'Гос. №' }
  ];

  constructor(private vehicleService: VehicleService) { }

  ngOnInit() {
    this.vehilces = this.vehicleService.collection;
  }

  removeVehicle(id: number) {
    this.vehicleService.RemoveVehicle(id);
  }
}
