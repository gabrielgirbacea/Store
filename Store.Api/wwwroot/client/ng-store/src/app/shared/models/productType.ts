import { Guid } from 'guid-typescript';

export interface IType {
  id: Guid | undefined;
  name: string;
}
