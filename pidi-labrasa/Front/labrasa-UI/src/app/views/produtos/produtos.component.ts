import { Component, OnInit } from '@angular/core';
import { Produto } from 'src/app/models/produto';
import { ProdutoService } from 'src/app/services/produto.service';

@Component({
  selector: 'app-produtos',
  templateUrl: './produtos.component.html',
  styleUrls: ['./produtos.component.css']
})
export class ProdutosComponent implements OnInit {

  public produtos: any = [];

  constructor(private produtoService: ProdutoService) {}

  ngOnInit(): void {
    this.pegarTodosProdutos();
  }

  pegarTodosProdutos() : void{
     this.produtoService.pegarTodos().subscribe((res: Produto) => {
     this.produtos = res;
     });
  }

}
