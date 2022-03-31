import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Produto } from '../models/produto';

@Injectable()
export class ProdutoService {
  constructor(private http: HttpClient) {}

  public pegarTodos(): Observable<Produto> {
    return this.http.get<Produto>('https://localhost:7298/api/produto');
  }
}
