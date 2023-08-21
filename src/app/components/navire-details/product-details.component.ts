import { Component, Input, OnInit } from '@angular/core';
import { Navire } from 'src/app/models/navire.model';
import { NavireService } from 'src/app/services/navire.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-navire-details',
  templateUrl: './navire-details.component.html',
  styleUrls: ['./navire-details.component.css']
})
export class ProductDetailsComponent implements OnInit  {

  @Input() viewMode = false;

  @Input() currentNavire: Navire = {
    numero: '',
    nom: '',
    annee:'',
    longueur: '',
    largeur:'',
    tonnageBrut:'',
    tonnageNet:'',
    note:''
  };

  message = '';

  constructor(
    private navireService: NavireService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    if (!this.viewMode) {
      this.message = '';
      this.getNavire(this.route.snapshot.params["id"]);
    }
  }

  getNavire(id: string): void {
    this.navireService.get(id)
      .subscribe({
        next: (data) => {
          this.currentNavire = data;
          console.log(data);
        },
        error: (e) => console.error(e)
      });
  }

  updateNote(note: any): void {
    const data = {
      nom: this.currentNavire.nom,
      note: this.currentNavire.note,
      annee: this.currentNavire.annee
    };

    this.message = '';

    this.navireService.update(this.currentNavire.numero, data)
      .subscribe({
        next: (res) => {
          console.log(res);
          this.currentNavire.note = note;
          this.message = res.message ? res.message : 'The note was updated successfully!';
        },
        error: (e) => console.error(e)
      });
  }

  updateNavire(): void {
    this.message = '';

    this.navireService.update(this.currentNavire.numero, this.currentNavire)
      .subscribe({
        next: (res) => {
          console.log(res);
          this.message = res.message ? res.message : 'This navire was updated successfully!';
        },
        error: (e) => console.error(e)
      });
  }

  deleteNavire(): void {
    this.navireService.delete(this.currentNavire.numero)
      .subscribe({
        next: (res) => {
          console.log(res);
          this.router.navigate(['/navires']);
        },
        error: (e) => console.error(e)
      });
  }
}
