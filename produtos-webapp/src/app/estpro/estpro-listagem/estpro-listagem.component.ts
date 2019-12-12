import { Component, OnInit } from '@angular/core';
import gql from 'graphql-tag';
import {Apollo} from 'apollo-angular';
import { Observable } from 'rxjs/internal/Observable';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-estpro-listagem',
  templateUrl: './estpro-listagem.component.html',
  styleUrls: ['./estpro-listagem.component.css']
})
export class EstproListagemComponent implements OnInit {
  estpro: Observable<any>;

  query = gql`
    {
      estpro{
        descri
      }
    }
  `;

  constructor(private apollo: Apollo) { }

  ngOnInit() {
    this.estpro = this.apollo
      .watchQuery<any>({
        query: this.query,
      })
      .valueChanges.pipe(map(result => result.data && result.data.estpro));
  }

}