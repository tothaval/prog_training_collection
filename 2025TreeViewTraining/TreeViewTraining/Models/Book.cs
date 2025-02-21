using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewTraining.Models;

public record Book(string Author, string Title, string Category, IEnumerable<int> Ratings);

