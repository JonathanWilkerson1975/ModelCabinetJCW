import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'fileSize'
})
export class FileSizePipe implements PipeTransform {

  transform(filesize: number): string {
    const byteSizes: number[] = [1000000000000000, 1000000000000, 1000000000, 1000000, 1000];
    //PB
    if (filesize >= byteSizes[0]) {
      return `${(filesize / byteSizes[0]).toFixed(1)} PB`;
    } //TB
    else if (filesize >= byteSizes[1]) {
      return `${(filesize / byteSizes[1]).toFixed(1)} TB`;
    } //GB
    else if (filesize >= byteSizes[2]) {
      return `${(filesize / byteSizes[2]).toFixed(1)} GB`;
    } //MB
    else if (filesize >= byteSizes[3]) {
      return `${(filesize / byteSizes[3]).toFixed(1)} MB`;
    } //KB
    else if (filesize >= byteSizes[4]) {
      return `${(filesize / byteSizes[4]).toFixed(1)} KB`;
    } //B
    else {
      return `${filesize} B`;
    }
  }

}
