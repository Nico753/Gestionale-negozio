using Negozio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Excel;

namespace Negozio.Controllers
{
    public class OpenXml
    {
        internal void StampaFattura(GestoreCarrello gestoreCarrello, double totaleSpesa, double pagamento, double resto, string metodoDiPagamento, string filePath,
                                    string numeroScontrino, Cliente cliente, int quantitaSacchetti)
        {
            ChangeBookmark(filePath, "NumeroScontrino", numeroScontrino);
            ChangeBookmark(filePath, "PrezzoTotaleComplessivo", totaleSpesa.ToString("F2"));
            ChangeBookmark(filePath, "Data", DateTime.Now.ToString("dd/MM/yyyy"));
            ChangeBookmark(filePath, "Ora", DateTime.Now.ToString("HH:mm"));
            ChangeBookmark(filePath, "IvaTotale", gestoreCarrello.CalcolaIvaTotale());
            ChangeBookmark(filePath, "TotaleResto", resto.ToString("F2"));
            ChangeBookmark(filePath, "MetodoDiPagamento", metodoDiPagamento);
            ChangeBookmark(filePath, "TotalePagato", pagamento.ToString("F2"));
            ChangeBookmark(filePath, "TotaleImportoPagato", totaleSpesa.ToString("F2"));
            ChangeBookmarkTable(filePath, gestoreCarrello.carrello, totaleSpesa, cliente, quantitaSacchetti);
            GeneraBarcode(numeroScontrino, filePath);
        }

        private void GeneraBarcode(string numeroScontrino, string filePath)
        {
            string barcodeValue = numeroScontrino;
            string barcodeImagePath = Path.Combine(Path.GetTempPath(), "barcode.png");

            var writer = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.CODE_128,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,
                    Height = 100,
                    Margin = 2
                }
            };

            using (var bitmap = writer.Write(barcodeValue))
            {
                bitmap.Save(barcodeImagePath, System.Drawing.Imaging.ImageFormat.Png);
            }

            ChangeBookmarkWithImage(filePath, "BarcodeScontrino", barcodeImagePath);

        }
        internal void ChangeBookmarkWithImage(string filePath, string bookmarkName, string imagePath)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = wordDocument.MainDocumentPart;

                ImagePart imagePart = mainPart.AddImagePart(ImagePartType.Png);
                using (FileStream stream = new FileStream(imagePath, FileMode.Open))
                {
                    imagePart.FeedData(stream);
                }

                string imagePartId = mainPart.GetIdOfPart(imagePart);

                var bookmarks = mainPart.RootElement.Descendants<BookmarkStart>();
                foreach (var bookmarkStart in bookmarks)
                {
                    if (bookmarkStart.Name == bookmarkName)
                    {
                        var parent = bookmarkStart.Parent;

                        var element =
                            new Run(
                                new Drawing(
                                    new DocumentFormat.OpenXml.Drawing.Wordprocessing.Inline(
                                        new DocumentFormat.OpenXml.Drawing.Wordprocessing.Extent()
                                        {
                                            Cx = 2628000,
                                            Cy = 781200
                                        },
                                        new DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent()
                                        {
                                            LeftEdge = 0,
                                            TopEdge = 0,
                                            RightEdge = 0,
                                            BottomEdge = 0
                                        },
                                        new DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties()
                                        {
                                            Id = (UInt32Value)1U,
                                            Name = "Barcode"
                                        },
                                        new DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties(
                                            new DocumentFormat.OpenXml.Drawing.GraphicFrameLocks() { NoChangeAspect = true }),
                                        new DocumentFormat.OpenXml.Drawing.Graphic(
                                            new DocumentFormat.OpenXml.Drawing.GraphicData(
                                                new DocumentFormat.OpenXml.Drawing.Pictures.Picture(
                                                    new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties(
                                                        new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties()
                                                        {
                                                            Id = (UInt32Value)0U,
                                                            Name = Path.GetFileName(imagePath)
                                                        },
                                                        new DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties()),
                                                    new DocumentFormat.OpenXml.Drawing.Pictures.BlipFill(
                                                        new DocumentFormat.OpenXml.Drawing.Blip()
                                                        {
                                                            Embed = imagePartId,
                                                            CompressionState = DocumentFormat.OpenXml.Drawing.BlipCompressionValues.Print
                                                        },
                                                        new DocumentFormat.OpenXml.Drawing.Stretch(
                                                            new DocumentFormat.OpenXml.Drawing.FillRectangle())),

                                                    new DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties(
                                                        new DocumentFormat.OpenXml.Drawing.Transform2D(
                                                            new DocumentFormat.OpenXml.Drawing.Offset() { X = 0, Y = 0 },
                                                            new DocumentFormat.OpenXml.Drawing.Extents()
                                                            {
                                                                Cx = 2628000,
                                                                Cy = 781200
                                                            }
                                                        ),
                                                        new DocumentFormat.OpenXml.Drawing.PresetGeometry(
                                                            new DocumentFormat.OpenXml.Drawing.AdjustValueList()
                                                        )
                                                        { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle })
                                                )
                                            )
                                            { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
                                    )
                                    { DistanceFromTop = 0, DistanceFromBottom = 0, DistanceFromLeft = 0, DistanceFromRight = 0 }
                                )
                            );

                        parent.InsertAfter(element, bookmarkStart);
                        break;
                    }
                }
                wordDocument.Save();
            }
        }
        internal void ChangeBookmarkTable(string filePath, List<Articolo> carrello, double totaleSpesa, Cliente c, int quantitaSacchetti)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = wordDocument.MainDocumentPart;
                Table existingTable = mainPart.Document.Body.Descendants<Table>().FirstOrDefault();

                if (existingTable != null)
                {
                    foreach (Articolo a in carrello)
                    {
                        string descrizione = a.DescrizioneArticolo;
                        if (a.DescrizioneArticolo.Length > 15)
                        {
                            descrizione = a.DescrizioneArticolo.Substring(0, 15) + ".";
                        }
                        TableRow newRow = new TableRow();

                        TableCell cell1 = new TableCell(new Paragraph(new ParagraphProperties(new WordWrap() { Val = false }), new Run(new RunProperties(
                                        new FontSize() { Val = "18" }
                                    ), new Text(descrizione))));

                        TableCell cell2 = new TableCell(
                            new Paragraph(
                                new ParagraphProperties(
                                    new Justification() { Val = JustificationValues.Right }
                                ),
                                new Run(
                                    new RunProperties(
                                        new FontSize() { Val = "18" }
                                    ),
                                    new Text(a.Iva + "%")
                                )
                            )
                        );

                        TableCell cell3 = new TableCell(
                            new Paragraph(
                                new ParagraphProperties(
                                    new Justification() { Val = JustificationValues.Right }
                                ),
                                new Run(new RunProperties(
                                        new FontSize() { Val = "18" }
                                    ), new Text(a.PrezzoConIva().ToString("F2")))
                            )
                        );

                        newRow.Append(cell1, cell2, cell3);
                        existingTable.Append(newRow);
                    }

                    if (quantitaSacchetti > 0)
                    {
                        for (int i = 0; i < quantitaSacchetti; i++)
                        {
                            TableRow SacchettoRow = new TableRow();
                            TableCell SacchettoCell = new TableCell(new Paragraph(new Run(new RunProperties(
                                        new FontSize() { Val = "18" }
                                    ), new Text("Sacchetto"))));
                            TableCell cellVuota = new TableCell(new Paragraph(new Run(new Text(""))));
                            TableCell PrezzoSacchetto = new TableCell(
                                new Paragraph(
                                    new ParagraphProperties(
                                        new Justification() { Val = JustificationValues.Right }
                                    ),
                                    new Run(new RunProperties(
                                        new FontSize() { Val = "18" }
                                    ), new Text("0,10"))
                                )
                            );
                            SacchettoRow.Append(SacchettoCell, cellVuota, PrezzoSacchetto);
                            existingTable.Append(SacchettoRow);
                        }
                    }

                    TableRow SubTotaleRow = new TableRow();
                    TableCell SubTotaleCell = new TableCell(new Paragraph(new Run(new RunProperties(
                                        new FontSize() { Val = "18" }
                                    ), new Text("SUBTOTALE"))));
                    TableCell CellVuota = new TableCell(new Paragraph(new Run(new Text(""))));
                    TableCell SubTotalePrezzoCell = new TableCell(
                        new Paragraph(
                            new ParagraphProperties(
                                new Justification() { Val = JustificationValues.Right }
                            ),
                            new Run(new RunProperties(
                                        new FontSize() { Val = "18" }
                                    ), new Text(carrello.Sum(x => x.PrezzoConIva()).ToString("F2")))
                        )
                    );
                    SubTotaleRow.Append(SubTotaleCell, CellVuota, SubTotalePrezzoCell);
                    existingTable.Append(SubTotaleRow);

                    if (c != null)
                    {
                        TableRow clienteRow = new TableRow();
                        TableCell clienteCell = new TableCell(new Paragraph(new Run(new Text("C.Fedeltà " + c.CodiceCartaFedeltaCensurato()))));
                        clienteRow.Append(clienteCell);
                        existingTable.Append(clienteRow);

                        foreach (Articolo a in carrello)
                        {
                            if (a.PrezzoConIva() > 150)
                            {
                                double sconto = a.PrezzoConIva() * 0.02;

                                TableRow scontoRow = new TableRow();

                                TableCell scontoCell = new TableCell(
                                    new Paragraph(new Run(new Text("Sconto 2% C.Fedeltà")))
                                );

                                TableCell valoreScontoCell = new TableCell(
                                    new Paragraph(
                                new ParagraphProperties(
                                    new Justification() { Val = JustificationValues.Right }
                                ),
                                new Run(new Text("-" + sconto.ToString("F2")))));

                                scontoRow.Append(scontoCell, valoreScontoCell);
                                existingTable.Append(scontoRow);
                            }
                        }
                    }
                }

                wordDocument.Save();
            }
        }

        internal void ChangeBookmark(string filePath, string bookmarkName, string newValue, string colore = "000000")
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                var parts = new List<OpenXmlPart> { wordDocument.MainDocumentPart };
                parts.AddRange(wordDocument.MainDocumentPart.HeaderParts);
                parts.AddRange(wordDocument.MainDocumentPart.FooterParts);

                foreach (var part in parts)
                {
                    IEnumerable<BookmarkStart> bookmarkStarts = part.RootElement.Descendants<BookmarkStart>();

                    foreach (BookmarkStart bookmarkStart in bookmarkStarts)
                    {
                        if (bookmarkStart.Name == bookmarkName)
                        {
                            Run run = bookmarkStart.NextSibling<Run>();
                            if (run != null)
                            {
                                if (run.RunProperties == null)
                                    run.RunProperties = new RunProperties();

                                if (colore != "000000")
                                    run.RunProperties.Append(new Color() { Val = colore });

                                Text text = run.GetFirstChild<Text>();
                                if (text != null)
                                    text.Text = newValue;
                            }
                        }
                    }
                }

                wordDocument.Save();
            }
        }

        internal void StampaReport(List<Cliente> lstClienti, List<Commesso> lstCommessi, List<Articolo> lstArticoliInEsaurimento, List<Fattura> totaleFatture, string mese, int anno, string filePath)
        {
            ChangeBookmark(filePath, "MESE", mese.ToUpper() + " " + anno);
            ChangeBookmark(filePath, "DATACREAZIONE", DateTime.Now.ToString("dd/MM/yyyy"));
            ChangeBookmarkTableCommessi(filePath, lstCommessi);
            ChangeBookmarkTableClienti(filePath, lstClienti);
            ChangeBookmarkTableArticoli(filePath, lstArticoliInEsaurimento);
            ChangeBookmark(filePath, "TOTALEFATTURATO", CalcolaTotaleFatturato(totaleFatture).ToString("C2"));
            ChangeBookmark(filePath, "TOTALEFATTURE", totaleFatture.Count.ToString());
            ChangeBookmark(filePath, "TOTALEIVA", CalcolaTotaleIVa(totaleFatture).ToString("C2"));
            ChangeBookmark(filePath, "PROFITTONETTO", (CalcolaTotaleFatturato(totaleFatture) - CalcolaTotaleIVa(totaleFatture)).ToString("C2"));
        }

        private double CalcolaTotaleIVa(List<Fattura> totaleFatture)
        {
            double totale = 0;
            foreach (Fattura f in totaleFatture)
            {
                totale += f.IvaTotale;
            }
            return totale;
        }

        private double CalcolaTotaleFatturato(List<Fattura> totaleFatture)
        {
            double totale = 0;
            foreach (Fattura f in totaleFatture)
            {
                totale += f.TotaleComplessivo;
            }
            return totale;
        }

        private void ChangeBookmarkTableArticoli(string filePath, List<Articolo> lstArticoliInEsaurimento)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = wordDocument.MainDocumentPart;
                Table existingTable = mainPart.Document.Body.Descendants<Table>().Skip(2).FirstOrDefault();

                if (existingTable != null)
                {
                    if (lstArticoliInEsaurimento == null || lstArticoliInEsaurimento.Count == 0)
                    {
                        AppendEmptyRow(existingTable, "Nessun articolo in esaurimento");
                    }
                    else
                    {
                        foreach (Articolo a in lstArticoliInEsaurimento)
                        {
                            TableRow newRow = new TableRow();
                            newRow.Append(
                                CreateStyledCell(a.DescrizioneArticolo),
                                CreateStyledCell(a.PrezzoConIva().ToString("C2")),
                                CreateStyledCell(a.Categoria),
                                CreateStyledCell(a.Quantita.ToString())
                            );
                            existingTable.Append(newRow);
                        }
                    }
                }

                wordDocument.Save();
            }
        }

        internal void ChangeBookmarkTableCommessi(string filePath, List<Commesso> lstCommessi)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = wordDocument.MainDocumentPart;
                Table existingTable = mainPart.Document.Body.Descendants<Table>().FirstOrDefault();

                if (existingTable != null)
                {
                    if (lstCommessi == null || lstCommessi.Count == 0)
                    {
                        AppendEmptyRow(existingTable, "Nessun commesso in questo mese");
                    }
                    else
                    {
                        foreach (Commesso c in lstCommessi)
                        {
                            TableRow newRow = new TableRow();
                            newRow.Append(
                                CreateStyledCell(c.Nome),
                                CreateStyledCell(c.Cognome),
                                CreateStyledCell(c.Email),
                                CreateStyledCell(c.Turno),
                                CreateStyledCell(c.OraInizioTurno.ToString(@"hh\:mm")),
                                CreateStyledCell(c.OraFineTurno.ToString(@"hh\:mm")),
                                CreateStyledCell(c.DataAssunzione.ToString("dd/MM/yyyy"))
                            );
                            existingTable.Append(newRow);
                        }
                    }
                }

                wordDocument.Save();
            }
        }
        internal void ChangeBookmarkTableClienti(string filePath, List<Cliente> lstClienti)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = wordDocument.MainDocumentPart;
                Table existingTable = mainPart.Document.Body.Descendants<Table>().Skip(1).FirstOrDefault();

                if (existingTable != null)
                {
                    if (lstClienti == null || lstClienti.Count == 0)
                    {
                        AppendEmptyRow(existingTable, "Nessun cliente in questo mese");
                    }
                    else
                    {
                        foreach (Cliente c in lstClienti)
                        {
                            TableRow newRow = new TableRow();
                            newRow.Append(
                                CreateStyledCell(c.CodiceFedelta.ToString()),
                                CreateStyledCell(c.Nome),
                                CreateStyledCell(c.Cognome),
                                CreateStyledCell(c.Email),
                                CreateStyledCell(c.StampaNumeroDiTelefono()),
                                CreateStyledCell(c.DataCrezione.ToString("dd/MM/yyyy"))
                            );
                            existingTable.Append(newRow);
                        }
                    }
                }

                wordDocument.Save();
            }
        }

        private TableCell CreateStyledCell(string text)
        {
            return new TableCell(
                new TableCellProperties(
                    new TableCellBorders(
                        new TopBorder { Val = BorderValues.Single, Size = 4 },
                        new BottomBorder { Val = BorderValues.Single, Size = 4 },
                        new LeftBorder { Val = BorderValues.Single, Size = 4 },
                        new RightBorder { Val = BorderValues.Single, Size = 4 }
                    ),
                    new TableCellVerticalAlignment { Val = TableVerticalAlignmentValues.Center }
                ),
                new Paragraph(
                    new ParagraphProperties(
                        new Justification { Val = JustificationValues.Center }
                    ),
                    new Run(
                        new RunProperties(
                            new RunFonts { Ascii = "Calibri" },
                            new FontSize { Val = "22" },
                            new Color { Val = "000000" }
                        ),
                        new Text(text) { Space = SpaceProcessingModeValues.Preserve }
                    )
                )
            );
        }

        private void AppendEmptyRow(Table table, string message)
        {
            int columnCount = table.Elements<TableRow>().FirstOrDefault()?
                .Elements<TableCell>().Count() ?? 1;

            TableRow emptyRow = new TableRow();

            TableCell cell = CreateStyledCell(message);

            TableCellProperties props = new TableCellProperties(
                new GridSpan() { Val = columnCount },
                new TableCellVerticalAlignment { Val = TableVerticalAlignmentValues.Center },
                new TableCellBorders(
                    new TopBorder { Val = BorderValues.Single, Size = 4 },
                    new BottomBorder { Val = BorderValues.Single, Size = 4 },
                    new LeftBorder { Val = BorderValues.Single, Size = 4 },
                    new RightBorder { Val = BorderValues.Single, Size = 4 }
                )
            );

            cell.TableCellProperties = props;

            Paragraph para = cell.GetFirstChild<Paragraph>();
            if (para != null)
            {
                ParagraphProperties paraProps = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Center }
                );
                para.PrependChild(paraProps);
            }

            emptyRow.Append(cell);
            table.Append(emptyRow);
        }
    }
}
